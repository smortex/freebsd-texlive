# New ports collection makefile for:	texlive-bin-gsftopk
# Date created:		26/01/2009 16:02:48
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-gsftopk
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Convert "ghostscript fonts" to PK files.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
