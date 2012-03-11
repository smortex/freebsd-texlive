# New ports collection makefile for:	texlive-beamer
# Date created:		13/03/2010 04:53:07
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	beamer
PORTVERSION=	20120311
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A LaTeX class for producing presentations and slides.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/pgf/basiclayer/pgf.sty:${PORTSDIR}/print/texlive-pgf \
		${LOCALBASE}/share/texmf-dist/tex/latex/xcolor/xcolor.sty:${PORTSDIR}/print/texlive-xcolor

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
