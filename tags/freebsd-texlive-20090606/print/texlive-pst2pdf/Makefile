# New ports collection makefile for:	texlive-pst2pdf
# Date created:		26/01/2009 16:11:16
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	pst2pdf
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A script to compile pstricks documents via pdftex.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
