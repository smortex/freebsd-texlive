# New ports collection makefile for:	texlive-beamer
# Date created:		26/01/2009 16:10:09
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	beamer
PORTREVISION=	2
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A LaTeX class for producing presentations and slides.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/pgf/basiclayer/pgf.sty:${PORTSDIR}/print/texlive-pgf \
		${LOCALBASE}/share/texmf-dist/tex/latex/xcolor/xcolor.sty:${PORTSDIR}/print/texlive-xcolor

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
