# New ports collection makefile for:	texlive-pdfpages
# Date created:		26/01/2009 16:10:19
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	pdfpages
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Include PDF documents in LaTeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/eso-pic/eso-pic.sty:${PORTSDIR}/print/texlive-eso-pic

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
