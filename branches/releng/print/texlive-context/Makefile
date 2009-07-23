# New ports collection makefile for:	texlive-context
# Date created:		26/01/2009 16:03:07
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	context
PORTREVISION=	11
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	The ConTeXt macro package.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/mptopdf/config/mptopdf.ini:${PORTSDIR}/print/texlive-bin-context \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/lm/lmb10.afm:${PORTSDIR}/print/texlive-lm

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
