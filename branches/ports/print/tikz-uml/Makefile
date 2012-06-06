# New ports collection makefile for:	tikz-uml
# Date created:		2012-05-23
# Whom:			Romain Tartiere <romain@FreeBSD.org>
#
# $FreeBSD$
#

PORTNAME=	tikz-uml
PORTVERSION=	0.9.8
CATEGORIES=	print
MASTER_SITES=	http://www.ensta-paristech.fr/~kielbasi/tikzuml/src/
DISTNAME=	tikzuml-v${PORTVERSION}-${RELEASEDATE}
EXTRACT_SUFX=	.tbz

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Draw UML diagrams using TikZ

RUN_DEPENDS=	share/texmf-dist/tex/latex/base/ifthen.sty:${PORTSDIR}/print/texlive-latex \
		share/texmf-dist/tex/latex/tools/calc.sty:${PORTSDIR}/print/texlive-tools \
		share/texmf-dist/tex/latex/pgf/frontendlayer/tikz.sty:${PORTSDIR}/print/texlive-pgf \
		share/texmf-dist/tex/generic/xstring/xstring.sty:${PORTSDIR}/print/texlive-xstring \
		share/texmf-dist/tex/latex/pgfopts/pgfopts.sty:${PORTSDIR}/print/texlive-pgfopts

USE_TBZ=	yes
RELEASEDATE=	2012-04-24
NO_BUILD=	yes
WRKSRC=		${WRKDIR}/tikzuml-v${PORTVERSION}

MKTEXLSR=	${LOCALBASE}/bin/mktexlsr

do-install:
	@${MKDIR} ${PREFIX}/share/texmf-dist/tex/latex/tikz-uml
	@(cd ${WRKSRC} && ${COPYTREE_SHARE} tikz-uml.sty ${PREFIX}/share/texmf-dist/tex/latex/tikz-uml)
.if !defined(NOPORTDOCS)
	@${MKDIR} ${PREFIX}/share/texmf-dist/doc/latex/tikz-uml
	@(cd ${WRKSRC}/doc && ${COPYTREE_SHARE} \* ${PREFIX}/share/texmf-dist/doc/latex/tikz-uml)
.endif

post-install:
	@${ECHO} "Updating ls-R databases..."
	@${MKTEXLSR}

.include <bsd.port.mk>
