# $FreeBSD$

PORTNAME=	tikz-timing
PORTVERSION=	20150413
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Easy generation of timing diagrams as tikz pictures.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/svn-prov/svn-prov.sty:${PORTSDIR}/print/texlive-svn-prov

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
