# New ports collection makefile for:	texlive-csplain
# Date created:		26/01/2009 16:06:02
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	csplain
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Plain TeX support for Czech/Slovak typesetting.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.csplain.cnf:${PORTSDIR}/print/texlive-bin-csplain

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
