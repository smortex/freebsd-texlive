# New ports collection makefile for:	texlive-mltex
# Date created:		26/01/2009 16:04:57
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	mltex
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	The MLTeX system.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.mltex.cnf:${PORTSDIR}/print/texlive-bin-mltex

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
